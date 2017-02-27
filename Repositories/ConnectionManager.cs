using System;
using System.Collections.Generic;
using Models;
using WebSocketSharp;

namespace Repositories
{
	public class ConnectionManager : IDisposable, IConnectionManager
	{
		List<WebSocket> webSockets;
		private string _url;
		private IRouter router;
		private ISerializer serializer;
		public String URL
		{
			get 
			{
				return _url;
			}
		}
		private void closeAllConnections()
		{
			foreach (var ws in webSockets)
			{
				ws.Close();
			}
		}
		public ConnectionManager(string URL, IRouter router, ISerializer serializer)
		{
			this._url = URL;
			webSockets = new List<WebSocket>()
			{
				new WebSocket(this._url)
			};
			this.router = router;
			this.serializer = serializer;
		}
		public void Dispose()
		{
			this.closeAllConnections();
		}

		void IDisposable.Dispose()
		{
			this.closeAllConnections();
		}

		protected WebSocket GetWebSocket()
		{
			var ws = this.webSockets[0];
			if (ws.ReadyState != WebSocketState.Open) {
				ws.Connect();
				webSockets[0].OnMessage += (sender, e) => this.router.Route(e.Data);
			}
			return ws;
		}
		protected String SerializeRequest(Request request)
		{
			return this.serializer.Serialize(request);
		}

		public void Send(Request request, IMessageReceiver receiver)
		{
			this.router.Register(request, receiver);
			this.GetWebSocket().Send(this.SerializeRequest(request));
		}
	}
}

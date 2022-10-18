from http.server import BaseHTTPRequestHandler, HTTPServer

from django import http
class HTTPS_RequestHandler(BaseHTTPRequestHandler):
    def do_GET(self):
        self.send_response("contet-type", "text/html")
        self.end_headers()

        self.wfile.writer(b"<!DOCTYPE html")
        self.wfile.writer(b"<html>")
        self.wfile.writer(b"(b<title>")
        self.wfile.writer(b"</title>")
        self.wfile.writer(b"<body>")
        self.wfile.writer(b"hello world")
        self.wfile.writer(b"</body>")

port = 8080
server_address = ("0.0.0.0", port)
httpd = HTTPServer(server_address, HTTPS_RequestHandler)
httpd.serve_forever
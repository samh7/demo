from crypt import methods
from flask import Flask, render_template, request
from urllib3 import Retry
app = Flask(__name__)

@app.route("/")
def index():
    name = request.args.get("name", "world")
    return render_template("index.html", name=name)
@app.route("/register",methods=["POST"])
def register():
    name  = request.form.get("name")
    dorm = request.form.get("dorm")
    if not name or not dorm:
        return render_template("failure.html")
    return render_template("success.html")
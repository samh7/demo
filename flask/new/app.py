from flask import Flask, request, render_template

app = Flask(__name__)

app.config["TEMPLATES_AUTO_RELOAD"] = True

@app.route("/")
def index():
    name = request.args.get("name", "World")
    return render_template("index.html",name=name)
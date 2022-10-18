from flask import Flask, render_template,request, redirect
import smtplib, os

students = []
app = Flask(__name__)
@app.route("/")
def index():
    name = request.args.get("name", "world")
    return render_template("index.html", name=name)

@app.route("/registered")
def registered():
    return render_template("registered.html", students=students)
@app.route("/register",methods=["POST"])
def register():
    name  = request.form.get("name")
    email = request.form.get("email")
    dorm = request.form.get("dorm")
    if not name or not dorm:
        return render_template("failure.html")
    
    message = "You are Registered"
    server = smtplib.SMTP("stmtp.gmail.com",587)
    server.starttls()
    server.login("samosasambusa@gmail.com",os.getenv("PASSWORD"))
    server.send("samosasambusa@gmail.com", email, message)
    return render_template("success.html")
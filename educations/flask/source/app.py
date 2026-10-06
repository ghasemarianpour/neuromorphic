from flask import Flask

app = Flask(__name__)

@app.route("/")

def welcome():
    return "<h1 style='color: red'>Welcome!</h1>"

if __name__ == "__main__":
    app.run(debug=True)
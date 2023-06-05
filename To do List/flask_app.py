from flask import Flask, render_template, request, redirect

app = Flask(__name__)

tasks = []

@app.route('/', methods=['GET', 'POST'])
def index():
    if request.method == 'POST':
        task_name = request.form.get('task')
        tasks.append({'name': task_name, 'completed': False})
    return render_template('index.html', tasks=tasks)

if __name__ == '__main__':
    app.run()


    app.run(debug=True)

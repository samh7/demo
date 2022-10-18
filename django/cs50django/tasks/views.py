from django.http import HttpResponseRedirect
from django.urls import reverse
from django.shortcuts import render
from django import forms


tasks = []
class NewTaskForm(forms.Form):
    task = forms.CharField(label="New Task")
    # prioity = forms.IntegerField(label="Priority", min_value=1,max_value=5)

def index(request):
    if "tasks" not in request.session:
        request.session["tasks"] = []
    return render(request, "tasks/index.html", {
        "tasks" : tasks
    })

def add(request):
    if request.method == "POST":
        form = NewTaskForm(request.POST)
        if form.is_valid():
            task = form.cleaned_data["task"]  
            tasks.append(task)
        else:
            return render(request, "tasks/add.html",{
                "form":form
            })
    return render(request, "tasks/add.html",{
        "form":NewTaskForm()
    })
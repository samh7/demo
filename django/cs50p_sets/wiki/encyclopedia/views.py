from django.shortcuts import render
from . import util
import random
from django import forms


class new_entry_form(forms.Form):
    name = forms.CharField(label="Name")
    content = forms.CharField(label="Content")

def index(request):
    return render(request, "encyclopedia/index.html", {
        "entries": util.list_entries()
    })


def get_request(request, title):
    if util.get_entry(title) is None:
        return render(request, "encyclopedia/404.html",)
    return render(request, "encyclopedia/get_request.html", {
        "title":title, 
        "entry":util.get_entry(title)
    })
def new_entry(request):

    if request.method =="POST":
        form =  new_entry_form()
        if form.is_valid():
            n_ame = form.cleaned_data["name"]
            c_ontent = form.cleaned_data["content"]
            util.save_entry(n_ame,c_ontent)
        # else:
        #     return render(request, "encyclopedia/new_entry.html",{
        #         "form":form
        #     })
    return render(request, "encyclopedia/new_entry.html",{
        "form": new_entry_form()
    })
        






def random(request):
    listt = util.list_entries()
    rand_choice =  random.choice(listt)
    return render(request, "encyclopedia/random.html", {
        "entries":rand_choice
    })
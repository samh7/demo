from django.urls import path

from . import views

urlpatterns = [
    path("", views.index, name="index"),
    path("<str:title>", views.get_request,name="get_request"),
    path("new_entry/", views.new_entry, name="new_entry"),
    path("random/", views.random, name="random"),
]

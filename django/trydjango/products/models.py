from email.policy import default
from itertools import product
from django.db import models

# Create your models here.
class product(models.Model):
    title = models.TextField()
    description = models.TextField()
    price = models.TextField()
    summary = models.TextField(default="this is cool")
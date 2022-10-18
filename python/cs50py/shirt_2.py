try:
    from PIL import Image
except ImportError:
    import Image
background = Image.open("f36day.png")
overlay = Image.open("shirt.png")
background = background.convert("RGBA")
overlay = overlay.convert("RGBA")
img_w, img_h = overlay.size
background.resize((img_w, img_h))
new_img = Image.blend(background, overlay, 0.5)
new_img.save("new.png","PNG")
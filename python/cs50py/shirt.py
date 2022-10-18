from PIL import  Image, ImageOps
def main():
    images = []
    shirt = Image.open("shirt.png")
    background = Image.open("f36day.png")
    img_w, img_h = shirt.size
    shirt.resize((img_w, img_h))
    background.resize((img_w, img_h))
    shirt.convert("RGBA")
    
    background = Image.blend(background,shirt,0.1)
    background.save("overlay.png")
    
if __name__ == "__main__":
    main()
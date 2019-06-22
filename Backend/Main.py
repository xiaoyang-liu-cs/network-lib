import Model
import Image
import matplotlib.pyplot as plt
import matplotlib as mpl
import tensorflow as tf

mpl.rcParams['figure.figsize'] = (10, 10)
mpl.rcParams['axes.grid'] = False

plt.figure(figsize=(10, 10))

tf.enable_eager_execution()

content_path = 'input/content.jpg'
style_path = 'input/style.jpg'

content = Image.load_img(content_path).astype('uint8')
style = Image.load_img(style_path).astype('uint8')

plt.subplot(1, 2, 1)
Image.imshow(content, 'Content Image')

plt.subplot(1, 2, 2)
Image.imshow(style, 'Style Image')

plt.show()

# Content layer where will pull our feature maps
content_layers = ['block5_conv2']

# Style layer we are interested in
style_layers = ['block1_conv1',
                'block2_conv1',
                'block3_conv1',
                'block4_conv1',
                'block5_conv1'
                ]

best, best_loss = Model.run_style_transfer(content_path,
                                           style_path, num_iterations=1000)

Image.show_results(best, content_path, style_path)

Image.save_results(best, 'output/output.jpg')

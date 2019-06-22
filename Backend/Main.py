import tensorflow as tf

import Image
import Model

tf.enable_eager_execution()

content_path = 'input/content.jpg'
style_path = 'input/style.jpg'

content = Image.load_img(content_path).astype('uint8')
style = Image.load_img(style_path).astype('uint8')

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

Image.save_results(best, 'output/output.jpg')

# Mobileum Abstract

My assignment was to create a static website using the BootStrap CSS framework.
I started the assignment by designing the menu bar, where I defined what menu items would be included. This gave me an idea of what pages would be needed and roughly what they would look like. I also started to make a design plan for this, but then quickly abandoned it, as a lot of it was more of a development project.

After several attempts, the site reached its current state. Even though it is a static page, I didn't want to have to rewrite a menu item change one by one in each HTML file. So I built the page in a modular way. The `main-elements` directory contains the header and footer elements. And the `sections` directory contains the sections of the spider layouts used on the main page and the hero section. I called these using JavaScript to the appropriate location. So I only had to place a shorter line of code for header, footer, and sections. This called the HTML file, which in turn contains the layout for that section. It was more useful this way because everything only needs to be modified in one place and each page is modular, so if I want to use an element more than once, I can do it much more easily this way. As a result, the code is more transparent. 
The phones also have a separate folder because I like everything to be organized in the background. This may seem redundant, but in the long run, it makes it easier for a larger project. 

The site itself approaches the subject from the point of view of the history of mobile phones, so I've also defined eras on the page and highlighted some of the more important phones, such as ones I've had the pleasure of using.
I have created a separate layout for each handset, which I have sub-placed on the sub-page of each handset. This way they can be displayed in a uniform way. 

To make the page more realistic, I also included a contact form on the `contact.html` page, which I created with JavaScript. When we submit the form, we are directed to a welcome page.

For the colors, I preferred a dark background, light font pairing. The site is clean, easy to navigate, and mobile optimized, i.e. responsive.
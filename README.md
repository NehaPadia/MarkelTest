# MarkelTest

Steps to follow:
1. please download the whole code
2. open it in visual studio
3. please run 'update-database' in package manager console so that it will use migration and it will create database with tables and add data to pagecontent & product tables.
4. If you fancy updating the data of pagecontent you have choice to use the page i created to manage the PageContents by typing url ending with /PageContents or please run the fill named as 'SQL-body text for page.sql' which will update the data in the database for page content
5. at this point you are reay to build and run the project and you will see three different types of page on the website, with the layout for each page
being controlled via the TemplateKey field in the database. These layouts are,
 Home page - fashion style homepage
 A regular content page –  more like an article
 A contact us page –  contact details and a contact us form that allows to capture the following information,
o Name
o Email address (accepts email only)
o Subject (50 char subject)
o Body (400 char free form text)
with submit button on the form and accompanying code to store the responses in the ContactUsResponse table in the database.

For additional functionality please have a look on below snaps 

![Home part1](https://user-images.githubusercontent.com/42066113/152456572-3540a8db-ad01-4162-b476-aebeab272e53.PNG)
![Home part2](https://user-images.githubusercontent.com/42066113/152456589-251e4dcc-d587-4e74-85e7-a065a6c8051c.PNG)
![Home part3](https://user-images.githubusercontent.com/42066113/152456598-fa91a7e4-dd2a-4f85-8a85-69c2fcb204ff.PNG)
![Home part4](https://user-images.githubusercontent.com/42066113/152456603-24377803-86dc-4de5-81a6-703a6589d97a.PNG)
![Home part5](https://user-images.githubusercontent.com/42066113/152456613-4a370072-2301-4ad7-a824-35b5f408d95f.PNG)

![Content part1](https://user-images.githubusercontent.com/42066113/152456632-716d0496-4e38-47ad-b7d1-570b42b67a73.PNG)
![Content part2](https://user-images.githubusercontent.com/42066113/152456636-00b4ddab-2933-405f-a36d-008a70bb2c45.PNG)
![Content part3](https://user-images.githubusercontent.com/42066113/152456661-74ab659c-cc07-4bf3-b575-d0688aadb04e.PNG)

![Contact us part1](https://user-images.githubusercontent.com/42066113/152456703-bd8e51a1-a2ac-44f8-be3e-4d34ddeae1c2.PNG)
![Contact us part2](https://user-images.githubusercontent.com/42066113/152456709-c396647e-f750-449e-8cbb-824f532d6a87.PNG)

![contact us confirmation](https://user-images.githubusercontent.com/42066113/152456716-3a82e120-173a-45cb-8741-31430d3b4cbb.PNG)

![Page content manage](https://user-images.githubusercontent.com/42066113/152456738-e355934d-4ccd-42fd-a7ac-09e10b739d81.PNG)

![Product manage](https://user-images.githubusercontent.com/42066113/152456754-776d82bb-6a4e-40b3-9898-d9ef08242e78.PNG)


![pagecontent table data](https://user-images.githubusercontent.com/42066113/152456768-0fdd333c-e836-4c49-83a0-3e15218ecc30.PNG)

![product table data](https://user-images.githubusercontent.com/42066113/152456775-b026f789-3a84-4116-8bbe-aa0ec0e729ba.PNG)


![test api mock dbcontext](https://user-images.githubusercontent.com/42066113/152456792-acf90d78-be77-4f13-8d1d-29f0ec2b9e6c.PNG)

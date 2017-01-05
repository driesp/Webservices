# installing windows Active Directory #

1. make sure all the latest updates are installed
2. go to the server manager
3. go to add roles and features
4. select role based installation and select AD DS.
````this will automatically install the dns service ````
5. After this you need to start the active directory setup program.
6. Just follow all the steps in the setup program and you should be good to go.

# Adding a windows computer machine to the domain#
1. go to computer properties.
2. select advanced settings
3. click change computer and workspace name.
4. instead of using the workgroup use the domain name.
5. use the FQDN of the domain controller -> look in the dns
6. use your administrator account to add the pc.
7. done

# Installing DNS
1. When installing AD they ask you to install DNS for that domain.
2. Following the provided steps the installation process is quite easy
3. done
4. The link with AD will be automcatically added. So all the domain pc's will automcatically take all the DNS information from the server and will push their information to the server.

# Installing IIS7 with project
1. make sure all the latest updates are installed
2. go to the server manager
3. go to add roles and features
4. select role based installation and select IIS.
5. Basic settings are enough for a simple ASP.net Application.
6. When done installing open IIS manager.
7. Create a new website by right clicking the server name and selecting new site.
8. Select a folder where your data will be placed and select which ip it should listen to and the adress. 
9. Export your project by rightclicking export on your asp.net project and select export to folder.
10. transport this folder to the server.
11. execute the script in this folder follewed by /Y and the project will be installed to the right website.
12. enjoy

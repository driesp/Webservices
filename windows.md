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

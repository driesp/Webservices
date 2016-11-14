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

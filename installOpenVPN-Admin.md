# Install OpenVPN-admin #

1. Download the repo from https://github.com/Chocobozzz/OpenVPN-Admin
2. Extract the contents.
3. Install the dependencies

````
# apt-get install openvpn apache2 php5-mysql mysql-server php5 nodejs unzip git wget sed npm
# npm install -g bower
# ln -s /usr/bin/nodejs /usr/bin/node
````

4. Enter the extracted folder 
5. execute following command ./install.sh ``www_base_dir`` ``web_user`` ``web_group``
6. The ``www_base_dir`` is the folder where you want to put your website --> see apache
7. Visit following website and create an admin user there(Only Possible after installation and single time)``http://your-installation/index.php?installation``

# Extra Configuration #

In the created conf files. I changed the port to 1194 and the protocol to UDP -> we did this for speed.

In the server configuration file we also changed the buffer size and we made it so that the DNS of the internal network was passed to the openVPN clients.


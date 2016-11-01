##installing Nagios for monitoring openvpn and webservers

### 1. installation
1. Install a LAMP server on Ubuntu. -> can be done from os installation.
2. create user for nagios. 
	1. useradd nagios
	2. groupadd nagcmd
	3. usermod -a -G nagcmd nagios
3. do an update of the packagelist ;)
4. install following packages (sudo apt-get instal xx)
	1. build-essentials
	2. libgd2-xpm-dev
	3. openssl
	4. libssl-dev
	5. xinetd
	6. apache2-utils
	7. unzip
5. Download the Nagios package and extract it
	1. use curl or wget
	2. extract the nagios package (tar xvf)
6. install nagios
	1. enter the nagios folder
	2. ./configure --with-nagios-group=nagios --with-command-group=nagcmd
	3. make all
	4. sudo make install
	5. sudo make install-commandmode
	6. sudo make install-init
	7. sudo make install-config
	8. sudo /usr/bin/install -c -m 644 sample-config/httpd.conf /etc/apache2/sites-available/nagios.conf
	9. make sure www-data is added to group nagcmd
7. install nagios plugins
	1. download with curl or wget
	2. unpack the package
	3. enter the folder
	4. configure with the plugins with following extra's --with-nagios-user=nagios --with-nagios-group=nagios --with-openssl
	5. execute make
	6. install with make
8. install NRPE
	1. download NRPE 2.15
	2. unpack the package
	3. enter the folder and configure it with the commands --enable-command-args --with-nagios-user=nagios --with-nagios-group=nagios --with-ssl=/usr/bin/openssl --with-ssl-lib=/usr/lib/x86_64-linux-gnu
	4. make all
	5. sudo make install
	6. sudo make install-xinetd
	7. sudo make install-daemon-config
	8. edit /etc/xinetd.d/nrpe (add at the end of only_from = 127.0.0.1 YOUR_SERVER_IP)
	9. restart the xinetd service
9. Configure nagios
	1. edit nagios.cfg (/usr/local/nagios/etc/nagios.cfg)
	2. remove the # from #cfg_dir=/usr/local/nagios/etc/servers
	3. create the nagios server folder sudo mkdir /usr/local/nagios/etc/servers
10. optional configure nagios contacts
	1. sudo nano /usr/local/nagios/etc/objects/contacts.cfg
	2. email                           nagios@localhost        ; <<***** CHANGE THIS TO YOUR EMAIL ADDRESS ******
11. edit the nrpe check command
	1. edit the /usr/local/nagios/etc/objects/commands.cfg
	2. add following to the end of the file 'define command{command_name check_nrpe command_line $USER1$/check_nrpe -H $HOSTADDRESS$ -c $ARG1$ }'
12. Configure apache
	1. enable rewrite and cgi
	2. add htpasswd file
		1. sudo htpasswd -c /usr/local/nagios/etc/htpasswd.users nagiosadmin
	3. create link of nagios.conf to the sites-enabled directory sudo ln -s /etc/apache2/sites-available/nagios.conf /etc/apache2/sites-enabled/
	4. restart nagios and apache2

###Add a monitored server (Windows)
1. install nsclient++
	1. make sure that firewallports are open.
	2. netsh firelwall set iscp 8
2. In the Config add the services that need to be checked.
3. make connection in the windows.cnf file
4. enable the windows.cnf file

###Install a new nagios theme(Arana Theme)
1. download the zip from their sourceforge page.
2. extract the contents to /usr/local/nagios/share
3. done!
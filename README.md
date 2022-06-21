# Marak Teimani WPF
This is a chatting app co-developed by [Ido Tziony](https://github.com/ghsumhubh) and [Idan Simai](https://github.com/idansi98) as part of the course "89211-Algorithmic Programming II" @ Bar-Illan Univeristy.


## How to Run  
1. Make sure you have correctly installed and ran the server from [here](https://github.com/idansi98/App/tree/UpdatedApi4)
2. Open ChatWPF/ChatWPF.sln
3. Run it using Visual Studio

## How to Use     
The user can register and login in order to get into the chat page.
In the chat page the user may contact new users and send them new text messages.


### Notes for Usage
1. In the contact creation screen, the expected server format is "ADDRESS_WITHOUT_HTTP:PORT", e.g., "localhost:7100".  
2. It is advised to not use the attachment button since, as of right now it is not functional.  


### Expected Behavior
1. Whenever a user tries to add a contact, if the request cannot be satisfied by either the local server or the contact's server, the contact should not be added to either one. 
2. Any change to a contact and or a message should be reflected in real time.









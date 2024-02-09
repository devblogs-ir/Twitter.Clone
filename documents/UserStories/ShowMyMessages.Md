**User Story Analysis: Show My Messages***


## **User Story**

As a **registered user**, I want to **Show My Messages** which I sent and recieved from other users.


## **Persona**


* **Registered User**: A user who has an account on user service which has a unique global id.


## **Need**:



* **Show My Messages***: The need to See the List Of My Messages between another users.


## **Purpose**



* **Show My Messages***: The purpose of sSee the List Of My Messages is to have a brief list of private communications between users. can be seen at a galance.


## **Analysis**


1. **User Flow**:
    * The application itself initiates the process by firing, then fetchs all undeleted messages between current user and
          other users by a database query.
    
2. **Validation and Error Handling**:
    * No especial validation is requiered. for relate guery just recipient’s user ID is requierde which exists in the system.
    * Handling first time request and when user deleted all messages is the matter that may return null value.

6. **Notifications**:
    * Implement notifications in the list of recieved messages, by query result of how many messages have not been seen.


## **Conclusion**

The “Show My Messages” feature is important as a history of chats between current user and other users. This issue is a show room of the service and can be a timeline of
actions that current user has done up to now.

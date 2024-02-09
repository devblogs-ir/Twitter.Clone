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
    * No especial validation is not requiered. for relate guery just recipient’s user ID is requierde which exists in the system.
    * Handling first time request and when user deleted all messages is the matter that may return null value.

6. **Notifications**:
    * Implement notifications in list of recieved messages, by query result of how many messages have not been seen.


## **Conclusion**

The “Send Direct Message” feature is critical for enabling private communication within our Direct Message service. By analyzing this user story, we can create a clear path for implementation, address potential challenges, and ensure a seamless user experience.

**User Story Analysis: Delete one Message****


## **User Story**

As a **registered user**, I want to **Delete one Message** which user has sent to another user or  has recieved from the other users.


## **Persona**


* **Delete one Message**: A user who has an account on user service which has a unique global id.


## **Need**:



* **Delete one Message***: The need to remove a simple sent or recieved message frmo a user, is just to have message id 
                            and also being the remover user of message must be one of the sender or reciever.


## **Purpose**



* **Delete one Message***: The purpose of Delete one message is that user does not need to have a simple message  in  chatbox with 
                            other users.So, it differs to delete all messages between two users.

## **Analysis**


1. **User Flow**:
    * Delete one Message operation fires by user (sender or reciever of the message)  for this pupose two properties have been predicted in database as "IsDeletedForSender" and "IsDeletedForReciver". According to  each side, the flag changes to "true". So, in this stage with delete just an update happends in database.
    * The main query which shows messages have a select on records fetches records  that "IsDeletedFor..." status is false for each side, So with changing to true, deleted records do not be shown in the collection for related side of sender or receiver. 
    
2. **Validation and Error Handling**:
    * A message could be deleted when the message be avilable in database.
    * User driver of deletion must has a sender or reciver role in considered message record. 
    

3. **Notifications**:
    * No especiall notification considerd for deleting a single message.


## **Conclusion**

The “Delete one Message” feature is be applied in deleting a sent or recieved message from each side. As a result, this feature is not a Permanent Delete from database.


### Permanently Deletion Policy:

For this goal a Background worker can be considered just one time running  during a day to remove  permanently.This Background worker sends a query to database and extracts all records that both flags changed to  true during last time period. So, all data which have two "IsDeleterforSender" and "IsDeletedForReciever" which true will be removed from database permanently.
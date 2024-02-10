**User Story Analysis: Message Status**

## **User Story**

As a **registered user**, I want to **see the status of my message** as sent or delivered.

## **Persona**

* **Registered User**: A user who has created an account on our Direct Message service.

## **Need**

* **See the status of Message**: The need to view status of own message as sent or delivered.

## **Purpose**

* **Ensuring that the message arrives**: The purpose of message status functional requirement is to makes us sure the message reaches the recipient.

## **Analysis**

1. **User Flow**:
    * After executing " send direct message " functional requirement, the message  state is sending. 
    * After receiving message by the server, system set a new state for the message (sent);
    * After receiving message by the recipient, system set a new state for the message (delivered).
    * After viewing the message by the recipient, system set a new state for the message (seen).

2. **Error Handling**:
    * Provide clear error messages for any validation failures.
    
3. **User Interface**:
    *  A blue circle means that your message is sending.
    * A blue circle with a check means that your message has been sent.
    * A filled-in blue circle with a check means that your message has been delivered.
    * A small version of someone's profile picture will appear below the message when they've seen it.
4. **Database Design**:
    * Define the schema to include fields for send date, receive date and seen date (seen/delivered).

## **Conclusion**

The "Message Status" is a functional feature that makes us sure that the message reaches the recipient.

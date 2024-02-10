**User Story Analysis: Notification**

## **User Story**

As a **registered user**, I want to **see the notification of my receive message** as email or web push notification.

## **Persona**

* **Recipient User**: A user who has created an account on our Direct Message service.

## **Need**

* **To be aware of receiving the new message**: The need to be aware of receive a new message by recipient.

## **Purpose**

* **Being aware of receiving a new message**: The purpose of the notification functional requirement is to be aware of the receipt of a new message.

## **Analysis**

1. **User Flow**:
    * After the recipient receives a new message, the system calls an API from the settings service to get the user's settings for receiving notifications.
    * If the user has set mute option for receiving the notification, the system won't send a notification.
    * If the user has set a custom option to receive notifications, the system will send notifications based on the configuration by calling an API from the notification service.

2. **Error Handling**:
    * Provide clear error messages for any validation failures.

## **Conclusion**

The "Send notification" is a functional feature that notifies the recipient of receiving a new message.

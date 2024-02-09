# **Introduction**

The purpose of this document is to provide a detailed description of the requirements and expectations for the development of a Direct Message(DM) service. This document outlines the high-level business requirements and end-user requirements.


# **Scope**

The direct messaging service is supposed to be a simple service at the first step that allows users to send and receive direct messages by selecting a user ID. The service should display received and sent messages, and messages should be plain text with no media or attachments. Viewing the message is not a real-time feature; users need to refresh the page to see new messages like an HTTP call. The service should show the message status as delivered or seen. Users can choose email or web push notification to be notified if they have a new message based on the setting that is set on the setting service. The service should also allow users to accept or block messages from new senders. If a sender is approved, the receiver can read the message, and the message status will change to delivered or seen. Users should be able to reply to and forward messages. Users should also be able to delete messages, either for the receiver or for both the receiver and sender.


# **Functional Requirements**



1. **User Registration**: Users should be able to register for the service by providing their name, email address, and password. (Mock or User service)
2. **Send Direct Message**: Users should be able to send a direct message to another user by selecting their user ID.
3. **Receive Direct Message**: Users should be able to receive direct messages from other users.
4. **Display Received Messages**: Users should be able to view the messages they have received.
5. **Display Sent Messages**: Users should be able to view the messages they have sent.
6. **Message Format**: Messages should be plain text with no media or attachments.
7. **Message Status**: The service should show the message status as delivered or seen.
8. **Notification**: Users can choose email or web push notification to be notified if they have a new message based on the setting that is set on the setting service.
9. **Accept or Block Messages:** Users should be able to accept or block messages from new senders. If a sender is approved, the receiver can read the message, and the message status will change to delivered or seen.
10. **Reply to Messages:** Users should be able to reply to messages.
11. **Forward Messages:** Users should be able to forward messages.
12. **Delete Messages:** Users should be able to delete messages, either for the receiver or for both the receiver and sender.


# **External Interface Requirements**



1. **User Interface**: -
2. **API**: The service should have an API that allows the DM service to interact with the Setting and Notification service. 


# **Future Requirements**



1. **Performance**: The service should be able to handle a large number of users and messages without slowing down.
2. **Security**: The service should be secure and protect user data from unauthorised access.
3. **Real-time messaging**  
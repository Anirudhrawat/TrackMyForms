# TrackMyForms

![image](https://github.com/user-attachments/assets/bf263d45-f25e-404a-8783-af97f85a821e)


![image](https://github.com/user-attachments/assets/b718f7cb-2e38-4bf7-b5ed-990db47c9fc9)



After Edit:

![image](https://github.com/user-attachments/assets/42bfa595-2abb-404b-a06d-b61a4a6976cc)


After Delete

![image](https://github.com/user-attachments/assets/f10fda8e-b0f4-492c-beca-03b714fb87bf)


Key things to note:

1. I’ve implemented **Layered Architecture (N-Tier)**, separating responsibilities across the Presentation, Business Logic, and Data Access layers. This includes proper use of **Dependency Injection** and the **Unit of Work** pattern to ensure clean and maintainable code.

2. I’ve added **Anti-Forgery Tokens** in all form submissions to protect against **Cross-Site Request Forgery (CSRF)** attacks.

3. The application uses **Entity Framework Core with an In-Memory Database** to simulate real database operations during development and testing.



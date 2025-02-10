import React, { useState, useEffect } from "react";

const EmailValidationForm = () => {

  const [email, setEmail] = useState("");
  const [isValid, setIsValid] = useState(true);

  useEffect(() => {
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    setIsValid(email === "" || emailRegex.test(email));
  }, [email]);

 
  const handleEmailChange = (e) => {
    setEmail(e.target.value);
  };

  return (
    <div style={{ margin: "20px", fontFamily: "Arial, sans-serif" }}>
      <h2>Email Validation Form</h2>
      <form>
        <div>
          <label htmlFor="email" style={{ fontWeight: "bold" }}>
            Enter Email:
          </label>
          <input
            type="text"
            id="email"
            value={email}
            onChange={handleEmailChange}
            placeholder="example@domain.com"
            style={{
              display: "block",
              padding: "8px",
              margin: "10px 0",
              border: "1px solid #ccc",
              borderRadius: "4px",
              width: "300px",
            }}
          />
          {email && (
            <div style={{ color: isValid ? "green" : "red" }}>
              {isValid
                ? "✅ Email format is valid"
                : "❌ Invalid email format. Please try again."}
            </div>
          )}
        </div>
      </form>
    </div>
  );
};

export default EmailValidationForm;

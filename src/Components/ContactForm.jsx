export function validateLogin(name, password) {
  if (name === "") return "Please enter your name";
  if (password.length < 6) return "Password must be at least 6 characters";
  return "";
}

export default function LoginForm() {
  function handleSubmit(e) {
    e.preventDefault();

    const name = document.getElementById("name").value;
    const password = document.getElementById("password").value;
    const message = document.getElementById("message");

    const error = validateLogin(name, password);

    if (error) {
      message.textContent = error;
    } else {
      message.textContent = "Welcome, " + name + "!";
    }
  }

  return (
    <form onSubmit={handleSubmit}>
      <h2>Login</h2>

      <label htmlFor="name">Name</label>
      <input id="name" />

      <label htmlFor="password">Password</label>
      <input id="password" type="password" />

      <button type="submit">Login</button>

      <p id="message"></p>
    </form>
  );
}
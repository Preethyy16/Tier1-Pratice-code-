import { render, screen, fireEvent } from "@testing-library/react";
import LoginForm from "./ContactForm";

// Test 1: the page shows the heading, fields and button
test("renders the login form", () => {
  render(<LoginForm />);

  expect(screen.getByRole("heading", { name: /login/i })).toBeInTheDocument();
  expect(screen.getByLabelText(/name/i)).toBeInTheDocument();
  expect(screen.getByLabelText(/password/i)).toBeInTheDocument();
  expect(screen.getByRole("button", { name: /login/i })).toBeInTheDocument();
});

// Test 2: clicking Login with empty fields shows an error
test("shows error when name is empty", () => {
  render(<LoginForm />);

  fireEvent.click(screen.getByRole("button", { name: /login/i }));

  expect(screen.getByText("Please enter your name")).toBeInTheDocument();
});

// Test 3: a valid login shows the welcome message
test("shows welcome message for valid login", () => {
  render(<LoginForm />);

  fireEvent.change(screen.getByLabelText(/name/i), { target: { value: "Alex" } });
  fireEvent.change(screen.getByLabelText(/password/i), { target: { value: "secret123" } });
  fireEvent.click(screen.getByRole("button", { name: /login/i }));

  expect(screen.getByText("Welcome, Alex!")).toBeInTheDocument();
});
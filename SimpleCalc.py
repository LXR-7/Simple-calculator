def calculator():
    while True:
        print("Simple Calculator")
        print("1. Addition")
        print("2. Subtraction")
        print("3. Multiplication")
        print("4. Division")
        print("5. Exit")

        choice = 0

        # Check if the input is a valid integer
        while True:
            try:
                choice = int(input("Enter your choice (1-5): "))
                if 1 <= choice <= 5:
                    break
                else:
                    print("Invalid choice. Please enter a number between 1 and 5.")
            except ValueError:
                print("Invalid choice. Please enter a number between 1 and 5.")

        if choice == 5:
            print("Exiting the calculator.")
            break

        num1 = float(input("Enter the first number: "))

        num2 = 0
        # Check if the input is a valid double
        while True:
            try:
                num2 = float(input("Enter the second number: "))
                break
            except ValueError:
                print("Invalid input. Please enter a valid number.")

        result = 0

        if choice == 1:
            result = num1 + num2
        elif choice == 2:
            result = num1 - num2
        elif choice == 3:
            result = num1 * num2
        elif choice == 4:
            if num2 != 0:
                result = num1 / num2
            else:
                print("Error: Division by zero is not allowed.")
                continue  # Skip further processing and restart the loop
        else:
            print("Invalid choice. Please enter a number between 1 and 5.")
            continue  # Skip further processing and restart the loop

        print(f"Result: {result}")

        # Ask the user if they want to continue
        continue_input = input("Do you want to continue? (y/n): ")
        if continue_input.lower() != "y":
            print("Exiting the calculator.")
            break

if __name__ == "__main__":
    calculator()
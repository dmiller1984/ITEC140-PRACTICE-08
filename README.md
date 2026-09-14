# Practice 08 — Name and Birthday

Guided, ungraded Windows Forms practice using multiple TextBoxes, a DateTimePicker, Labels, and Buttons.

The earlier discussion left the second app's precise theme flexible. This version uses first name, last name, and birth date to practice reading controls and displaying a result. Age calculation is an optional later extension. This is an original practice exercise, not an identified textbook tutorial or graded assignment.

## Part 1 — Setup

1. On this repository page, click **Code** and copy the HTTPS clone address.
2. In Visual Studio, choose **Clone a repository**, paste it, and select **Clone**.
3. If you see a folder view, double-click the `.sln` file.
4. In Solution Explorer, right-click **Form1.cs** and choose **View Designer**.
5. Press **F5** once. A blank form is expected. Close the running form before editing.
6. Open **View > Toolbox** to add controls. Select a control and press **F4** for Properties.
7. Use **(Name)** for the identifier used in code; use **Text** for visible wording.
8. Save everything with **Ctrl+Shift+S**.

Use Windows with Visual Studio and the **.NET desktop development** workload and .NET 10 SDK. These are blank WinForms starter projects: you place the controls and write each event handler while practicing. No completed solution is included.

On a computer where you already cloned this repository, open that existing solution and use **Git > Pull** before making new edits. If you have uncommitted edits, save and review them first; ask for help if Git reports a conflict.


## Part 2 — Create the GUI

Set Form1's **Text** to `Name and Birthday`. Place labels on the left, input controls on the right, and buttons underneath.

| Control | (Name) | Text / key settings |
| --- | --- | --- |
| Label | lblFirstName | First name: |
| TextBox | txtFirstName | Text: leave blank |
| Label | lblLastName | Last name: |
| TextBox | txtLastName | Text: leave blank |
| Label | lblBirthDate | Birth date: |
| DateTimePicker | dtpBirthDate | Format: Short |
| Button | btnDisplay | Display |
| Button | btnClear | Clear |
| Button | btnExit | Exit |
| Label | lblResult | Text: leave blank; AutoSize: False; Size: 460, 70 |

1. Use the Toolbox to place each control.
2. Select one control at a time and enter its **(Name)** and **Text** in Properties.
3. The date picker displays a date itself; you do not type a date into its Text property.
4. Check the two text boxes are blank, and the buttons display their intended wording.
5. Save All, run, then close the form.
6. Commit and push: `Create Name and Birthday form layout`.

## Part 3 — Write and test the Display action

1. Double-click the **Display** button in the Designer.
2. Start small: make the result label display only the first-name text box's **Text**.
3. Run and test with a made-up first name.
4. Stop the app. Extend your expression to include a space and the last-name text box's **Text**.
5. Test again.
6. Now include the selected birth date. A DateTimePicker's **Value** is a DateTime value. Its `ToShortDateString()` method produces display text.
7. Build a message in the form: `Hello, Alex Example! Your birth date is [selected date].`
8. Use string concatenation, or the string technique your class is using. Ask your tutor to explain each piece before adding it.
9. Change both the name and date and click Display again. Check the label updates.
10. Stop, Save All, commit and push: `Read names and birth date and display a message`.

The Short date format follows the computer's regional settings; it is not guaranteed to be month/day/year. Use made-up details for practice screenshots.

## Part 4 — Write and test Clear and Exit

1. Double-click **Clear** to create its Click handler.
2. Make both name text boxes empty and clear the result label.
3. Reset the date picker's Value to today's date.
4. Put keyboard focus back in the first-name text box.
5. Double-click **Exit** and write the instruction that closes the form.
6. Run the app: enter data → Display → Clear. Check all the intended fields reset.
7. Enter new data and display again. Finally test Exit.
8. Stop, Save All, commit and push: `Add Clear and Exit behavior`.

## Optional later extension — Age in completed years

Complete the basic display exercise first. This extension needs date comparisons and decision logic.

1. Reject a birth date in the future with a helpful message.
2. Start with today's year minus the selected birth year.
3. If this year's birthday has not happened yet, subtract one.
4. Add the age to the result.
5. Decide how a February 29 birthday is treated in a non-leap year. Document that choice.
6. Test a birthday today, tomorrow, yesterday, and a future date; test the leap-day rule separately.
7. Explain why subtracting the years alone can give an age that is one year too high.

## Completion checklist

- [ ] I can explain (Name) versus Text.
- [ ] Display reads both TextBoxes and the selected date.
- [ ] A second click reflects changed inputs.
- [ ] Clear resets the inputs and output.
- [ ] Exit closes the form.
- [ ] I can explain Text, Value, and a Click event.
- [ ] My commits are pushed and visible on GitHub.

Starter files were checked structurally; Windows build/run must be checked in Visual Studio. Preparation of this repository does not mean the exercise is completed.

## If stuck

See [Syntax and controls](SYNTAX-AND-CONTROLS.md). Stop at the first error and compare the exact control name and property. Work through one action at a time with your tutor.

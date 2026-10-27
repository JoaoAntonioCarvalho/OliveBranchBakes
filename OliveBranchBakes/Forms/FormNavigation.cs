namespace OliveBranchBakes.Forms
{
    // Shows a message for forms that are not built yet,
    // so the buttons do not crash the app.
    public static class FormNavigation
    {
        public static void ShowPlannedForm(string formName)
        {
            MessageBox.Show("The " + formName + " form will be added in a later phase.",
                "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowPrototypeMessage()
        {
            MessageBox.Show("This is only a prototype. This button will work in a later phase.",
                "Prototype", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

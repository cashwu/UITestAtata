using Atata;
using Atata.Bootstrap;

namespace testAtata
{
    using _ = UserEditWindow;

    [WaitFor(Until.MissingOrHidden, TriggerEvents.DeInit)]
    public class UserEditWindow : BSModal<_>
    {
        public TextInput<_> FirstName { get; private set; }

        public TextInput<_> LastName { get; private set; }

        [RandomizeStringSettings("{0}@mail.com")]
        public TextInput<_> Email { get; private set; }

        public Select<Office?, _> Office { get; private set; }

        [FindByName]
        public RadioButtonList<Gender?, _> Gender { get; private set; }

        [Term("Save", "Create")]
        public ButtonDelegate<UsersPage, _> Save { get; private set; }

        public ButtonDelegate<UsersPage, _> Cancel { get; private set; }

        [FindByClass]
        public ButtonDelegate<UsersPage, _> Close { get; private set; }
    }
}
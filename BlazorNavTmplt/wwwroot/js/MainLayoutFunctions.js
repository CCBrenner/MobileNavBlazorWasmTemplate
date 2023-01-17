
// Initialize deferredPrompt for use later to show browser install prompt.
let deferredPrompt;


function InitializeInstallAppPrompt() {
    window.addEventListener('beforeinstallprompt', (e) => {

        // Prevent the mini-infobar from appearing on mobile
        e.preventDefault();

        // Stash the event so it can be triggered later.
        deferredPrompt = e;
    });
}

function InstallApp() {

    // Show the install prompt
    deferredPrompt.prompt();

    // Wait for the user to respond to the prompt
    const { outcome } = await deferredPrompt.userChoice;

    // We've used the prompt, and can't use it again, throw it away
    deferredPrompt = null;
});

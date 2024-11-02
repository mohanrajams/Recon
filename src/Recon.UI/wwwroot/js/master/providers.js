function AppViewModel() {
    this.message = ko.observable("Hello, Knockout!");
}

// Apply the bindings to activate Knockout
const viewModel = new AppViewModel();
ko.applyBindings(viewModel);
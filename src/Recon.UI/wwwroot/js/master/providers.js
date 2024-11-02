(function (jq, kn) {

    var baseAddress = window.location.origin;

    async function loadProvider() {

        const url = baseAddress + "/api/provider";

        try {
            const response = await fetch(url);

            if (!response.ok) {
                throw new Error(`Response status: ${response.status}`);
            }

            const providers = await response.json();

            return providers;

        } catch (error) {
            console.error(error.message);
        }
    }

    var providerViewModel = function (providers) {

    }

    jq(loadProvider);

})($, ko);


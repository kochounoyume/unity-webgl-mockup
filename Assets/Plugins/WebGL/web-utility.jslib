mergeInto(LibraryManager.library, {

    ConsoleLog: function (message) {
        console.log(UTF8ToString(message));
    },

    ConsoleWarn: function (message) {
        console.warn(UTF8ToString(message));
    },

    ConsoleError: function (message) {
        console.error(UTF8ToString(message));
    },

    MovePageURL(pageName) {
        window.history.pushState({}, '', window.location.origin + '/' + UTF8ToString(pageName));
    },

});
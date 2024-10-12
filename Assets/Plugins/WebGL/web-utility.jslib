mergeInto(LibraryManager.library, {

    MovePageURL: function (pageName) {
        window.history.pushState({}, '', window.location.origin + '/' + UTF8ToString(pageName));
    },

});
mergeInto(LibraryManager.library, {

    MovePageURL: function (pageName) {
        console.log(pageName);
        window.history.pushState({}, '', window.location.origin + '/' + UTF8ToString(pageName));
    },

});
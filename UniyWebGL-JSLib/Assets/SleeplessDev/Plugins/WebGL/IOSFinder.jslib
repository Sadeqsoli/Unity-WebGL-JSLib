// IOSFinder.jslib
mergeInto(LibraryManager.library, {
    CheckForWebGLIOS: function() {
        var isIOS = [
            'iPad Simulator',
            'iPhone Simulator',
            'iPod Simulator',
            'iPad',
            'iPhone',
            'iPod'
        ].includes(navigator.platform) 
        // iPad on iOS 13+ detection
        || (navigator.userAgent.includes("Mac") && "ontouchend" in document);

        return isIOS ? 1 : 0;
    }
});

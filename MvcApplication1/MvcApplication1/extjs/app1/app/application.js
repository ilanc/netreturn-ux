Ext.define('App1.Application', {
    extend: 'Ext.app.Application',
    name: 'App1',
    autoCreateViewport: false,      // NOTE: careful it's not overridden in ../app.js
    appFolder: _EXTROOT + '/app1/app',  // NOTE: needs to be in app.js & app/application.js. Careful it's not overridden in bootstrap.js

    views: [
        'SimpleGrid'
    ],

    controllers: [
        // TODO: add controllers here
    ],

    stores: [
        'SimpleStore'
    ],

    launch: function () {
        // Use launch() rather than autoCreateViewport - Viewports take over the entire page
        //debugger;
        Ext.create('App1.view.SimpleGrid', {    // NOTE: matches "alias" in view/SimpleGrid.js
            renderTo: 'main',                   // NOTE: <div id="main"> declared in see _Layout.cshtml
            height: 350,
            width: 600
        });
    }
});

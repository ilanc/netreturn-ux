Ext.define('App1.Application', {
    extend: 'Ext.app.Application',
    name: 'App1',
    autoCreateViewport: false,      // NOTE: careful it's not overridden in ../app.js
    appFolder: _EXTROOT + '/app1/app',  // NOTE: needs to be in app.js & app/application.js. Careful it's not overridden in bootstrap.js

    views: [
        'SimpleGrid', 'SimpleLineChart'
    ],

    controllers: [
        // TODO: add controllers here
    ],

    stores: [
        'SimpleStore', 'SimpleChartStore'
    ],

    launch: function () {
        // Use launch() rather than autoCreateViewport - Viewports take over the entire page
        //debugger;
        Ext.create('Ext.container.Container', {
            renderTo: 'main',                   // NOTE: <div id="main"> declared in see _Layout.cshtml
            height: 500,
            width: 1000,
            layout: 'hbox',
            items: [{
                xtype: 'app1-simplegrid',
                width: 500,
                height: 400
            }, {
                xtype: 'splitter',
                width: 10,
                vertical: true
            }, {
                xtype: 'app1-simplelinechart',
                width: 400,
                height: 400
            }]
        });
    }
});

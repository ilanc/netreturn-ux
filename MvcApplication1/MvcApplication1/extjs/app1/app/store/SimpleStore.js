Ext.define('App1.store.SimpleStore', {
    extend: 'Ext.data.Store',
    model: 'App1.model.SimpleModel',
    autoLoad: true,
    proxy: {
        type: 'ajax',
        url: '/api/app1/',
        reader: {
            type: 'json'
        }
    }
});
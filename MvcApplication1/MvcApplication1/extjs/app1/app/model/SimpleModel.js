Ext.define('App1.model.SimpleModel', {
    extend: 'Ext.data.Model',
    fields: [
        { name: 'company' },
        { name: 'price', type: 'float' },
        { name: 'change', type: 'float' },
        { name: 'pctChange', type: 'float' },
        { name: 'lastChange', type: 'date', dateFormat: 'n/j h:ia' }
    ]
});

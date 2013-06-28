Ext.define('App1.model.SimpleChartModel', {
    extend: 'Ext.data.Model',
    idProperty: 'ID',
    fields: [
     { name: 'ID', type: 'number' },
     { name: 'Month', type: 'string' },
     { name: 'Sample1', useNull: true }
    ]
});

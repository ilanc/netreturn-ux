// NOTE: Global scope - just for demo
function change(val) {
    if (val > 0) {
        return '<span style="color:green;">' + val + '</span>';
    } else if (val < 0) {
        return '<span style="color:red;">' + val + '</span>';
    }
    return val;
}

function pctChange(val) {
    if (val > 0) {
        return '<span style="color:green;">' + val + '%</span>';
    } else if (val < 0) {
        return '<span style="color:red;">' + val + '%</span>';
    }
    return val;
}

// Define the grid
Ext.define('App1.view.SimpleGrid', {
    /*requires: [
        'Ext.grid.Panel'
    ],*/
    extend: 'Ext.grid.Panel',
    xtype: 'app1-simplegrid',

    title: 'Simple Grid',
    store: 'SimpleStore',
    columns: [
        {
            text: 'Company',
            flex: 1,
            sortable: false,
            dataIndex: 'company'
        },
        {
            text: 'Price',
            width: 75,
            sortable: true,
            renderer: 'usMoney',
            dataIndex: 'price'
        },
        {
            text: 'Change',
            width: 75,
            sortable: true,
            renderer: change,
            dataIndex: 'change'
        },
        {
            text: '% Change',
            width: 75,
            sortable: true,
            renderer: pctChange,
            dataIndex: 'pctChange'
        },
        {
            text: 'Last Updated',
            width: 85,
            sortable: true,
            renderer: Ext.util.Format.dateRenderer('m/d/Y'),
            dataIndex: 'lastChange'
        }
    ],
    viewConfig: {
        stripeRows: true
    }
});
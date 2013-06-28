var chartData = [
{ ID: 1, Month: "Jan-11", Sample1: 40 },
{ ID: 2, Month: "Feb-11", Sample1: 20},
{ ID: 3, Month: "Mar-11", Sample1: 20},
{ ID: 4, Month: "Apr-11", Sample1: 40},
{ ID: 5, Month: "May-11", Sample1: 20},
{ ID: 6, Month: "Jun-11", Sample1: 40},
{ ID: 7, Month: "Jul-11", Sample1: 20},
{ ID: 8, Month: "Aug-11", Sample1: 40},
{ ID: 9, Month: "Sep-11", Sample1: 20},
{ ID: 10, Month: "Oct-11", Sample1: 40},
{ ID: 11, Month: "Nov-11", Sample1: 20},
{ ID: 12, Month: "Dec-11", Sample1: 40}
];

Ext.define('App1.store.SimpleChartStore', {
    extend: 'Ext.data.Store',
    model: 'App1.model.SimpleChartModel',
    autoLoad: true,
    data: (_INDEXHTML === true) ? chartData : null,
    proxy: {
        type: (_INDEXHTML === true) ? 'memory' : 'ajax',
        url: '/api/app1/chart',
        reader: {
            type: 'json'
        }
    }
});
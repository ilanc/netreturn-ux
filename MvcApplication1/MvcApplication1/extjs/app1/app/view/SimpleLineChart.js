Ext.define('App1.view.SimpleLineChart', {
    extend: 'Ext.chart.Chart',
    xtype: 'app1-simplelinechart',

    title: 'Simple Line Chart',
    style: 'background:#fff',
    store: 'SimpleChartStore',
    legend: {
        position: 'right'
    },
    axes: [{
        type: 'Numeric',
        position: 'left',
        fields: ['Sample1'],
        title: 'Value'
    }, {
        type: 'Category',
        position: 'bottom',
        fields: ['Month'],
        title: 'Month'
    }],
    series: [{
        type: 'line',
        axis: 'left',
        xField: 'Month',
        yField: 'Sample1'
    }]
});
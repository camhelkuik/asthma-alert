import DS from 'ember-data';

export default DS.Model.extend({
    date: DS.attr('string'),
    grassValue: DS.attr('number'),
    treeValue: DS.attr('number'),
    plantGraminalesValue: DS.attr('number'),
    plantJuniperValue: DS.attr('number'),
    plantElmValue: DS.attr('number'),
    plantOakValue: DS.attr('number'),
    plantPineValue: DS.attr('number'),
    plantCottonWoodValue: DS.attr('number'),
    plantBirchValue: DS.attr('number'),
    plantAshValue: DS.attr('number'),
    plantMapleValue: DS.attr('number')
});

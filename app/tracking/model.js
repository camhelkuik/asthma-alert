import DS from 'ember-data';

export default DS.Model.extend({
    hadAttack: DS.attr('number'),
    date: DS.attr('date'),
    userId: DS.attr('number')
});

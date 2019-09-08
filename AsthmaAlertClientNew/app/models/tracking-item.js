import DS from 'ember-data';

export default DS.Model.extend({
    hadAttack: DS.attr("number"),
    date: DS.attr("string"),
    trackingTitle: DS.attr("string"),
    owner: DS.belongsTo("person")
});

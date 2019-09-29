import DS from 'ember-data';

export default DS.Model.extend({
    date: DS.attr("string"),
    asthmaValue: DS.attr("number"),
    asthmaCategory: DS.attr("string"),
    dustDanderValue: DS.attr("number"),
    dustDanderCategory: DS.attr("string")
});

import DS from 'ember-data';

export default DS.Model.extend({
    date: DS.attr('string'),
    ozone: DS.attr('string'),
    ozoneAQI: DS.attr('number'),
    ozoneCategory: DS.attr('number'),
    fineParticles: DS.attr('string'),
    fineParticlesAQI: DS.attr('number'),
    fineParticlesCategory: DS.attr('number'),
    combined: DS.attr('string'),
    combinedAQI: DS.attr('number'),
    combinedCategory: DS.attr('number')
});

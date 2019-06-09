import Controller from '@ember/controller';
import $ from 'jquery';
import EmberObject from '@ember/object';

export default Controller.extend({
    hasPollenData: false,
    pollenData: null,

    actions: {
        getDailyPollen() {
            $.get("https://api.breezometer.com/pollen/v2/forecast/daily?lat=30.003362&lon=-95.594209&days=1&key=22c2cf4e6d9b4a9ea35d14230ced8e7a&features=types_information,plants_information").then((response) => {
                
                var pollenData = EmberObject.create({
                    date: response.data[0].date,
                    grassValue: response.data[0].types.grass.index.value,
                    treeValue: response.data[0].types.tree.index.value,
                    plantGraminalesValue: response.data[0].plants.graminales.index.value,
                    plantJuniperValue: response.data[0].plants.juniper.index.value,
                    plantElmValue: response.data[0].plants.elm.index.value,
                    plantOakValue: response.data[0].plants.oak.index.value,
                    plantPineValue: response.data[0].plants.pine.index.value,
                    plantCottonWoodValue: response.data[0].plants.cottonwood.index.value,
                    plantBirchValue: response.data[0].plants.birch.index.value,
                    plantAshValue: response.data[0].plants.ash.index.value,
                    plantMapleValue: response.data[0].plants.maple.index.value
                });

                this.set('pollenData', pollenData);
                this.set('hasPollenData', true);

                const dailyPollen = this.store.createRecord('daily-pollen', { date: this.get('pollenData.date'), grassValue: this.get('pollenData.grassValue'), treeValue: this.get('pollenData.treeValue'),
                plantGraminalesValue: this.get('pollenData.plantGraminalesValue'), plantJuniperValue: this.get('pollenData.plantJuniperValue'), plantElmValue: this.get('pollenData.plantElmValue'),
                plantOakValue: this.get('pollenData.plantOakValue'), plantPineValue: this.get('pollenData.plantPineValue'), plantCottonWoodValue: this.get('pollenData.plantCottonWoodValue'),
                plantBirchValue: this.get('pollenData.plantBirchValue'), plantAshValue: this.get('pollenData.plantAshValue'), plantMapleValue: this.get('pollenData.plantMapleValue') });
            
                 dailyPollen.save();
            });
        }
    }
});

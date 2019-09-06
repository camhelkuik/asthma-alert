import { module, test } from 'qunit';
import { setupTest } from 'ember-qunit';

module('Unit | Route | daily-pollen', function(hooks) {
  setupTest(hooks);

  test('it exists', function(assert) {
    let route = this.owner.lookup('route:daily-pollen');
    assert.ok(route);
  });
});

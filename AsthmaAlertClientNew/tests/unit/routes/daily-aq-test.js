import { module, test } from 'qunit';
import { setupTest } from 'ember-qunit';

module('Unit | Route | daily-aq', function(hooks) {
  setupTest(hooks);

  test('it exists', function(assert) {
    let route = this.owner.lookup('route:daily-aq');
    assert.ok(route);
  });
});

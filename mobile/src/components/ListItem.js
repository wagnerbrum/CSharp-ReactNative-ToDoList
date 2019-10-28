import React from 'react';
import {StyleSheet, View, Text} from 'react-native';

import theme from '../theme/default';

export default ListItem = ({item}) => {
  return (
    <View
      style={[
        styles.listItem,
        item.state === 1 && styles.listItemSuccess,
        item.state === 2 && styles.listItemWarning,
        item.state === 3 && styles.listItemDanger,
      ]}
      key={item.id}>
      <View style={styles.containerItemAvatar}>
        <View
          style={[
            styles.itemAvatar,
            item.state === 1 && styles.itemAvatarSuccess,
            item.state === 2 && styles.itemAvatarWarning,
            item.state === 3 && styles.itemAvatarDanger,
          ]}>
          <Text style={styles.itemAvatarText}>{item.id}</Text>
        </View>
      </View>
      <View style={styles.containerItemBody}>
        <View style={styles.itemBodyLeft}>
          <Text
            style={[
              styles.itemSubHeader,
              item.state === 1 && styles.itemSubHeaderSuccess,
              item.state === 2 && styles.itemSubHeaderWarning,
              item.state === 3 && styles.itemSubHeaderDanger,
            ]}>
            Task {item.id}
          </Text>
          <Text style={styles.itemHeader}>{item.description}</Text>
        </View>
        <View style={styles.itemBodyRight}>
          {item.state === 1 && (
            <Text style={styles.itemState}>Waiting{'\n'}Add Item</Text>
          )}
          {item.state === 2 && (
            <Text style={styles.itemState}>Task{'\n'}Completed</Text>
          )}
          {item.state === 3 && (
            <Text style={styles.itemState}>Task Not{'\n'}Completed</Text>
          )}
        </View>
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  listItem: {
    flexDirection: 'row',
    borderWidth: 1,
    borderLeftWidth: 6,
    height: 70,
    alignItems: 'center',
    marginBottom: 16,
  },
  listItemSuccess: {
    borderColor: theme.success,
  },
  listItemWarning: {
    borderColor: theme.warning,
  },
  listItemDanger: {
    borderColor: theme.danger,
  },
  containerItemAvatar: {},
  itemAvatar: {
    height: 38,
    width: 38,
    borderRadius: 19,
    margin: 16,
    justifyContent: 'center',
    alignItems: 'center',
  },
  itemAvatarSuccess: {
    backgroundColor: theme.success,
  },
  itemAvatarWarning: {
    backgroundColor: theme.warning,
  },
  itemAvatarDanger: {
    backgroundColor: theme.danger,
  },
  itemAvatarText: {
    fontSize: 18,
    fontWeight: 'bold',
    color: 'white',
  },
  containerItemBody: {
    flexDirection: 'row',
    flex: 1,
    justifyContent: 'space-between',
    marginRight: 16,
  },
  itemBodyLeft: {},
  itemSubHeader: {
    fontSize: 14,
  },
  itemSubHeaderSuccess: {
    color: theme.success,
  },
  itemSubHeaderWarning: {
    color: theme.warning,
  },
  itemSubHeaderDanger: {
    color: theme.danger,
  },
  itemHeader: {
    fontSize: 18,
    fontWeight: 'bold',
    marginTop: 1,
  },
  itemBodyRight: {
    justifyContent: 'center',
  },
  itemState: {
    textAlign: 'center',
    color: theme.textCalled,
  },
});
